import { Component, OnInit } from '@angular/core';
import { take } from 'rxjs';
import { Items } from '../Models/items';
import { ProductsService } from '../Services/products.service';

@Component({
  selector: 'app-product-i',
  templateUrl: './product-i.component.html',
  styleUrls: ['./product-i.component.css'],
  
})
export class ProductIComponent implements OnInit {
/*produtcs:Array<Items>=[]*/
data:any

  constructor(private productService: ProductsService) { }

  ngOnInit() {
    this.productService.GetItems().subscribe((data: Items[]) => {
      this.data = data;
    });
  }

}
