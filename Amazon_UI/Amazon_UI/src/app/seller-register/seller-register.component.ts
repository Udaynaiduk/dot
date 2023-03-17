import { Component,OnInit } from '@angular/core';
import { Seller } from '../Models/seller';
import { SellerService } from '../Services/seller.service';

@Component({
  selector: 'app-seller-register',
  templateUrl: './seller-register.component.html',
  styleUrls: ['./seller-register.component.css']
})
export class SellerRegisterComponent implements OnInit {
se:Seller=new Seller()
constructor(public ss:SellerService){}
  ngOnInit(): void {
    
  }
  Register(){
    this.ss.SellerRegister(this.se)
    this.se=new Seller()
  }
}
