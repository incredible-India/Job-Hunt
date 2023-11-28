import { Component,OnInit } from '@angular/core';
import {userClient} from  "./../../../services/user-client";
import { NewUser } from 'src/app/Models/newUser';
@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
  /**
   *
   */
  constructor(private userService : userClient) {
      
  }
  ngOnInit(): void {
    this.user();
  }

  body:NewUser = {
    Age :12,
    FirstName :"LastName",
    LastName :"Namya H.S",
     AlternatePhoneNo : "0010010111",
     Gender : "Male",
     Password : "1234567890",
     PhoneNo : "1001001001",
  }

 user(){
let  res= this.userService.UserRegistration(this.body)
  console.log(res);
 }

 
  

}
