import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { NewUser } from 'src/app/Models/newUser';
import { userService } from 'src/app/services/userService';
@Component({
  selector: 'app-new-user',
  templateUrl: './new-user.component.html',
  styleUrls: ['./new-user.component.css']
})
export class NewUserComponent {

  /**
   *
   */
  showError:boolean = false;
  Errormessage:string =""
  constructor(private user:userService) {

  }

  //defining the new form group
  newUser = new FormGroup({

    fname: new FormControl('', [Validators.required,Validators.minLength(3)]),
    lname: new FormControl('', [Validators.required,Validators.minLength(3)]),
    //userName: new FormControl('', [Validators.required,Validators.email]),
    password: new FormControl('', [Validators.required,Validators.minLength(5)]),
    phoneNumber: new FormControl('', [Validators.required,Validators.minLength(10),Validators.maxLength(10)]),
    alternatePhoneNumber: new FormControl('',[Validators.minLength(10),Validators.maxLength(10)]),
    gender: new FormControl('', [Validators.required]),
    age: new FormControl('', [Validators.required,Validators.min(18)]),

  })

  submit(){

  var body:NewUser = {
    FirstName: this.newUser.value["fname"] || undefined,
    LastName:this.newUser.value["lname"] || undefined,
    Age: this.newUser.value["age"] !== undefined ? parseInt(this.newUser.value["age"] as string) : undefined,
    PhoneNo: this.newUser.value["phoneNumber"] || undefined,
    AlternatePhoneNo:this.newUser.value["alternatePhoneNumber"] || undefined,
    Password: this.newUser.value["password"] || undefined,
    Gender: this.newUser.value["gender"] || undefined,
  }


  this.user.newUser(body).subscribe(x=>{

  })
  }

  NewUserRegistration() {
    // console.log(this.newUser.value);
    console.log(this.newUser);
    this.submit();
  }

  get fname() {
    return this.newUser.get('fname');
  }
  get lname() {
    return this.newUser.get('lname');
  }
  // get userName() {
  //   return this.newUser.get('userName');
  // }
  get password() {
    return this.newUser.get('password');
  }
  get phoneNumber() {
    return this.newUser.get('phoneNumber');
  }
  get alternatePhoneNumber() {
    return this.newUser.get('alternatePhoneNumber');
  }
  get gender() {
    return this.newUser.get('gender');
  }
  get age() {
    return this.newUser.get('age');
  }
}
