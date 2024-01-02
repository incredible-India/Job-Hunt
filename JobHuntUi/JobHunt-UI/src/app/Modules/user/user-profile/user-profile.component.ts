import { Component,OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { userService } from 'src/app/services/userService';


@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.css']
})

export class UserProfileComponent implements OnInit {
  userId : any;
  userData : any;
  constructor(private route : ActivatedRoute, private user : userService) {
    this.route.params.subscribe(x =>{
      this.userId = x["id"]
    })
  }

  getUserData() {
    this.user.getUserById(this.userId).subscribe(u=>{
      console.log(u);
      if(u.status == 404){
        this.userData =null;
        throw console.error("user not found");
       
        
      }else{
        this.userData=u;
      }
      
    })
  }

  ngOnInit(): void {
    this.getUserData();
  }

  

}
