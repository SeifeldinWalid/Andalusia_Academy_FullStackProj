using Full_Stack_Grad_Project.Data;
using Full_Stack_Grad_Project.Exceptions;
using Full_Stack_Grad_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace Full_Stack_Grad_Project.Repo
{
    public class UserRepo
    {
        private readonly ApplicationDbContext _context;

        public UserRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToArrayAsync();
        }
        public async Task<User> CreateUser(User user)
        {
            var newUser = await _context.Users.FirstOrDefaultAsync(p => p.Email == user.Email);
            if (newUser == null)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return user;
            }
            throw new AlreadyExistException("Email Already exist");
        }

        public async Task<User> GetUserById(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(p => p.Id == id);
            if(user != null)
            {
                return user;
            }
            throw new NotFoundException("User Not Found");
        }
        
        //public async Task<List<Course>> GetUserCourses(int id)
        //{
        //} 

    }
}
