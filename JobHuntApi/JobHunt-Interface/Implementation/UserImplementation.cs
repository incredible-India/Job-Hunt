using JobHunt_Interface.Interface;
using JobHunt_Models.Database;
using JobHunt_Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Interface.Implementation
{
    public class UserImplementation : IUser
    {
        private readonly jobHuntContext _jobHuntContext;

        public UserImplementation(jobHuntContext jobHuntContext)
        {
            _jobHuntContext = jobHuntContext;   
        }

        //this will validate the user info
        public async Task<List<dynamic>> IsValidUserInfo(NewUser user)
        {
           
            //first
            if(user.FirstName.Length <=3){
                return new List<dynamic>() { false,"First Name Should be Greater than 3 chars"};
            }
            if (user.Age <18) {
                return new List<dynamic>() { false, "Age should be greater than 18" };
                }
            if (user.Password.Length <=5) {
                return new List<dynamic>() { false, "Password should be greater than 5" };
            }
            if (user.PhoneNo.Length!=10 ) {
                return new List<dynamic>() { false, "Phone Number should be equal to 18" };
            }

            var isExist = _jobHuntContext.Users.Where(x => x.PhoneNo == user.PhoneNo);
            if (isExist.Any()) { return new List<dynamic>() { false, "User already exist with this phone number, try to login..." }; }

            return new List<dynamic>() { true , user};
            
        }

        public async Task<dynamic> StoreInfoInDb(NewUser user)
        {
            //Storing the data of the validated user in database
            var isValid = await  IsValidUserInfo(user);


            if (isValid[0] ==true) {

                _jobHuntContext.Users.Add(user);
                _jobHuntContext.SaveChanges();
                return isValid[1];
            }
            else
            {
                return isValid[1];
            }
        }

        //to check whether the phone number and password is correct or not
        public async Task<List<dynamic>> UserExist(Login user)
        {
            var isExist = _jobHuntContext.Users.Where(x => x.PhoneNo == user.PhoneNo);
                     

            if(isExist.Any())
            {
                if (isExist.ToList()[0].Password == user.Password)
                {
                    return new List<dynamic>() { true,"Login Success" };
                }
                else
                {
                    return new List<dynamic>() { false, "Invalid credentials" };
                }
            }
            else
            {
                return new List<dynamic>() { false, "Invalid credentials" };
           }
          
        }

    }
}
