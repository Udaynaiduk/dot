import { Component, OnInit } from '@angular/core';
import { Goldornment } from '../models/goldornment';
import { JewelleryService } from '../services/jewellery.service';

@Component({
  selector: 'app-display',
  templateUrl: './display.component.html',
  styleUrls: ['./display.component.css']
})
export class DisplayComponent implements OnInit {
  gc:Array<Goldornment>=[]
  constructor(public js:JewelleryService){
    this.js.Goldornments().subscribe(
      (success)=>{
        this.gc=success;
     } )
  }

  ngOnInit(): void {
  }

}




