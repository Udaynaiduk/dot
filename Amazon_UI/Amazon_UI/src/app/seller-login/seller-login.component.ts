import { Component, OnInit } from '@angular/core';
import { Seller } from '../Models/seller';
import { SellerService } from '../Services/seller.service';

@Component({
  selector: 'app-seller-login',
  templateUrl: './seller-login.component.html',
  styleUrls: ['./seller-login.component.css']
})
export class SellerLoginComponent implements OnInit {
se:Seller=new Seller()
constructor(public ss:SellerService){}

  ngOnInit(): void {
    
  }
  sellerH(){
    this.ss.SellerLogin(this.se)
    this.se=new Seller()
  }
}
