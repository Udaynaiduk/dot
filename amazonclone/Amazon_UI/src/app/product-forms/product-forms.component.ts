import { Component, OnInit } from '@angular/core';
import { Items } from '../Models/items';
import { ProductsService } from '../Services/products.service';

@Component({
  selector: 'app-product-forms',
  templateUrl: './product-forms.component.html',
  styleUrls: ['./product-forms.component.css']
})
export class ProductFormsComponent implements OnInit {
  i:Items=new Items();
  ngOnInit(): void {
    
  }
  constructor(private p:ProductsService){}
  submit(){
    this.p.Add(this.i);
    this.i=new Items()
    
  }

}
