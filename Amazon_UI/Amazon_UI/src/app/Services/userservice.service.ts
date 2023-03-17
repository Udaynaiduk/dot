import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../Models/user';
import {Observable} from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class UserserviceService  {

  constructor(private client:HttpClient, private router:Router) { }
  
  login(us:User)
{
  this.client.post<User>("http://localhost:5172/api/User1",us).subscribe(
    {
    next:(result:any)=>{console.log("success"+JSON.stringify(result)) ;
    localStorage.setItem('token',result.token)
    this.router.navigate(["/Home"])
  } ,
    
    error:(error)=>{console.log("error"+JSON.stringify(error))}
    }
    )

}
register(us:User)
{
  this.client.post<User>("http://localhost:5172/api/User",us).subscribe(
    {
    next:(s)=>{console.log(s)},
    error:(error)=>console.log(error)
    }
    )

}

}
