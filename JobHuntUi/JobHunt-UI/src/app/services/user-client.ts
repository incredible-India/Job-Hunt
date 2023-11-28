import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import * as config from "./../../assets/config.json"
import { Observable } from "rxjs";
import {NewUser} from "./../Models/newUser";
@Injectable({
    providedIn:'root'
})

export class userClient{

    constructor(private http:HttpClient) {

        
    }
  baseUrl:any = config.baseUrl;
//for the new user registration
UserRegistration(body:NewUser):Observable<any>{
    const url = this.baseUrl + '/jobhunt/user/registration';
    var response = this.http.post(url,body);
    return response;
}
    
}