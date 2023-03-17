import { Component, OnInit } from '@angular/core';
import { Goldornments } from '../Model/goldornments';
import { JewelleryService } from '../service/jewellery.service';

@Component({
  selector: 'app-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.css']
})
export class ShowComponent implements OnInit 
{

  data:Array<Goldornments> = []

  constructor(public js:JewelleryService) 
  { 
    this.js.getOrnments().subscribe({
      next: (s)=>{
         this.data=s;
         console.log("success"+JSON.stringify(this.data));
       },
       error:(error)=>console.log(error)
     }
     )
  }
    
  

  ngOnInit(): void {
  }

}
