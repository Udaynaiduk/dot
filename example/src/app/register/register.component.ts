import { Component, OnInit } from '@angular/core';
import { Goldornment } from '../models/goldornment';
import { JewelleryService } from '../services/jewellery.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
go:Goldornment=new Goldornment()
  constructor(public js:JewelleryService) { }


  ngOnInit(): void {
  }
  saveHandler(){
    this.js.addornment(this.go);
    this.go=new Goldornment();
  }

}
