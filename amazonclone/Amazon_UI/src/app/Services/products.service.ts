import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Items } from '../Models/items';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor(private c:HttpClient) { }

  GetItems():Observable<Array<any>>{
    return this.c.get<Array<any>>('http://localhost:5001/api/items')
  }
  Add(us:Items)
{
  this.c.post<Items[]>("http://localhost:5001/api/items",us).subscribe(
    {
    next:(s)=>{console.log(s)
     
    },
    error:(error)=>console.log(error)
    }
    )
}
}
