import { Component,OnInit } from '@angular/core';
import {FormControl,FormGroup,Validators} from "@angular/forms"
import { login} from 'src/app/Models/login';
import { userService } from 'src/app/services/userService';
@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
  /**
   *
   */
  constructor(private user:userService) {
      
  }

  loginUser = new FormGroup({
    phone : new FormControl("",[Validators.required,Validators.minLength(10),Validators.maxLength(10)]),
    password : new FormControl("",[Validators.required,Validators.minLength(5)])
  })

  submitLogin(){
    
    var body :login = {
      Password: this.loginUser.value["password"] || undefined,
      PhoneNo: this.loginUser.value["phone"] || undefined
    }

    this.user.login(body).subscribe(r=>{

      console.log(r);
    },error=>{
     
      
    })
    
  }

  get phone(){
    return this.loginUser.get("phone")
  }
  get password(){
    return this.loginUser.get("password")
  }
  ngOnInit(): void {

 

  }



 
  

}
