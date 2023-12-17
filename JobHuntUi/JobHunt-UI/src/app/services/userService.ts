import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { login } from "../Models/login";
import { NewUser } from "../Models/newUser";
@Injectable ({
    providedIn: 'root'
})

export class userService{
    constructor(private http: HttpClient) {
        
        
    }

    baseUrl : string="https://localhost:44321/"

    login(body:login):Observable<any>{
        const url = this.baseUrl + "jobhunt/user/login";
        return this.http.post<any>(url,body)

    }

    newUser(body:NewUser){
        const url = this.baseUrl + "jobhunt/user/registration";
        return this.http.post<any>(url,body)
    }
}