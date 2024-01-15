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
  jobProvider : any;
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
        this.getJobProvider();
      }
    
    })
  }

  getJobProvider(){
    this.user.getJobs(this.userData.phoneNo).subscribe(j=>{
      if(j.status == 404){
        this.jobProvider = null;
        throw console.error("No jobs available..");
        
      }
      else{
        this.jobProvider = j;
      }
      console.log(j,"job data");
      
    })
  }

  ngOnInit(): void {
    this.getUserData();
    
  }

  

}
