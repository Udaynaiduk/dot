import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Items } from '../Models/items';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private c:HttpClient) { }

  GetItems():Observable<Array<Items>>{
    return this.c.get<Array<Items>>('http://https://jsonplaceholder.typicode.com/posts:5261/api/items')
  }
  
}
