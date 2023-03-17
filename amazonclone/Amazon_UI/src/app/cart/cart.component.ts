import { Component, OnInit } from '@angular/core';
import { Items } from '../Models/items';
import { CartService } from '../Services/cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})

  export class CartComponent implements OnInit {
    items: Items[] = [];
    totalValue = 0;
    totalQuantity = 0;
  
    constructor(private cartService: CartService) { }
  
    ngOnInit() {
      this.items = this.cartService.getItems();
      this.totalValue = this.cartService.getTotalValue();
      this.totalQuantity = this.cartService.getTotalQuantity();
    }
  
    removeItem(item: Items) {
      this.cartService.removeItem(item);
      this.items = this.cartService.getItems();
      this.totalValue = this.cartService.getTotalValue();
      this.totalQuantity = this.cartService.getTotalQuantity();
    }
  
    clearCart() {
      this.cartService.clearCart();
      this.items = this.cartService.getItems();
      this.totalValue = this.cartService.getTotalValue();
      this.totalQuantity = this.cartService.getTotalQuantity();
    }
  }
  