import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Goldornment } from '../models/goldornment';
import { Logins } from '../models/logins';

@Injectable({
  providedIn: 'root'
})
export class JewelleryService {
gc:Array<Goldornment>=[]

  constructor(private Client:HttpClient) { }

  Goldornments():Observable<Array<Goldornment>>{
    return this.Client.get<Array<Goldornment>>("http://localhost:5004/Gold");
  }
  addornment(go:Goldornment){
   // this.gc.push(go);
   this.Client.post<Goldornment>("http://localhost:5004/Gold",go)
   .subscribe(
    {
      next:(success)=>{console.log(success)},
      error:(error)=>console.log(error)
      
    }
   )


  }
  
}
