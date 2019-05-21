using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using SchoolRegister.BLL.Entities;
using SchoolRegister.DAL.EF;
using SchoolRegister.ViewModels.VMs;

namespace SchoolRegister.Web.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _dbContext;

        public ChatHub(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SendMessageAll(MessageVm message)
        {
            message.Author = GetAuthenticatedUser().UserName;
            Clients.All.SendAsync("ShowMessage", message);
        }

        public void SendMessageToUser(MessageVm message)
        {
            message.Author = GetAuthenticatedUser().UserName;
            var rescipient = _dbContext.Users.FirstOrDefault(u => u.UserName == message.RecipientName);
            if (rescipient != null)
            {
                Clients.User(rescipient.Id.ToString()).SendAsync("ShowMessage", message);
            }
        }

        public void SendMessageToGroup(MessageVm message)
        {
            message.Author = GetAuthenticatedUser().UserName;
            Clients.Group(message.RecipientName).SendAsync("ShowMessage", message);
        }
        public override Task OnConnectedAsync()
        {
            SetGroups();
            return base.OnConnectedAsync();
        }
        private void SetGroups()
        {
            var user = GetAuthenticatedUser();
            if (user is Student student)
            {
                Groups.AddToGroupAsync(Context.ConnectionId, student.Group.Name);
            }
        }
       

        private User GetAuthenticatedUser()
        {
            var authenticatedUser = ((ClaimsIdentity)Context.User?.Identity)?.Claims?.First()?.Value;
            if (authenticatedUser == null) throw  new Exception("User not authenticated");
            var user = _dbContext.Users.FirstOrDefault(u => u.UserName == authenticatedUser);
            if (user == null) throw new Exception("Given user does not exist in the database.");
            return user;
        }
    }
}
