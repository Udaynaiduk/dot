import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Goldornments } from 'src/app/Model/goldornments';


@Injectable({
  providedIn: 'root'
})
export class JewelleryService {
gc:Array<Goldornments>=[]
  constructor(private Client:HttpClient) { 
  
    
  }
  getOrnments():Observable<Array<Goldornments>>{
    return this.Client.get<Array<Goldornments>>("http://localhost:5004/Gold");
  }
  add(go:Goldornments){
    this.Client.post<Goldornments>("http://localhost:5004/Gold",go).subscribe(
      {
        next:(s)=>{console.log(s)},
        error:(error)=>console.log(error)
      }
    )
  }
}
