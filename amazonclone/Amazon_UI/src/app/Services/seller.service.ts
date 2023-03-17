import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Seller } from '../Models/seller';

@Injectable({
  providedIn: 'root'
})
export class SellerService {

  se:Array<Seller>=[]
  constructor(private cl:HttpClient,private router:Router) { }
  SellerRegister(se:Seller){
    this.cl.post<Seller>("http://localhost:5001/api/Seller/Register",se).subscribe({
      next:(s)=>{console.log(s)
     
      
      },
      error:(e)=>{console.log(e)}

      
    })
   

    
  }
  SellerLogin(se:Seller){
    this.cl.post<Seller>("http://localhost:5001/api/Seller/Validate",se).subscribe(
      {
      next:(result:any)=>{console.log("success"+JSON.stringify(result)) ;
      localStorage.setItem('token',result.token)
          this.router.navigate(["/items"])
    } ,
      
      error:(error)=>{console.log("error"+JSON.stringify(error))}
      }
      )
  }
  logout(){
    localStorage.removeItem('token')
  }
}
