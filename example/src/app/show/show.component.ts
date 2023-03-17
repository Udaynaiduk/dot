import { Component, OnInit } from '@angular/core';
import { Goldornment } from '../models/goldornment';
import { JewelleryService } from '../services/jewellery.service';

@Component({
  selector: 'app-show',
  templateUrl: './show.component.html',
  styleUrls: ['./show.component.css']
})
export class ShowComponent implements OnInit {
  gc:Array<Goldornment>=[]
  constructor(public js:JewelleryService) { 
    this.js.Goldornments().subscribe(
      (success)=>{
        this.gc=success;
     } )
    }

  ngOnInit(): void {
  }

}
