import { Component, OnInit } from '@angular/core';
import { Goldornments } from '../Model/goldornments';
import { JewelleryService } from '../service/jewellery.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {
go:Goldornments=new Goldornments();
  constructor(public js:JewelleryService) { }

  ngOnInit(): void {
  }
save(){
  this.js.add(this.go)
  this.go=new Goldornments
}
}
