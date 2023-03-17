import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Seller } from '../Models/seller';

@Injectable({
  providedIn: 'root'
})
export class SellerService {

  se:Array<Seller>=[]
  constructor(private cl:HttpClient) { }
  SellerRegister(se:Seller){
    this.cl.post<Seller>("http://localhost:5172/api/Seller/Register",se).subscribe({
      next:(s)=>{console.log(s)},
      error:(e)=>{console.log(e)}
      
    })
  }
  SellerLogin(se:Seller){
    this.cl.post<Seller>("http://localhost:5172/api/Seller/Validate",se).subscribe({
      next:(s)=>{console.log(s)},
      error:(e)=>{console.log(e)}
      
    })
  }
}
