import { Component, Input, OnInit } from '@angular/core';
import { take } from 'rxjs';
import { Items } from '../Models/items';
import { CartService } from '../Services/cart.service';
import { ProductsService } from '../Services/products.service';
import { UserserviceService } from '../Services/userservice.service';

@Component({
  selector: 'app-product-i',
  templateUrl: './product-i.component.html',
  styleUrls: ['./product-i.component.css'],
  
})
export class ProductIComponent implements OnInit {
//produtcs:Array<Items>=[]
@Input() count: number = 2;
@Input() view: 'grid' | 'list' | 'currcartitem' | 'prevcartitem' = 'grid';
produtcs?:Array<any>;

  constructor(private productService: ProductsService,private cartService:CartService,public s:UserserviceService) { }

  ngOnInit() {
    this.productService.GetItems().subscribe((data) => {
      this.produtcs = data;
      console.log(data)
    });
  }
  addToCart(item: Items) {
    item.qty = 1
    this.cartService.addItem(item);
    window.alert(`${1} ${item.title}(s) added to cart!`);
  }

}
