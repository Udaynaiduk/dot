import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AddComponent } from '../add/add.component';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }
handel(){
  this.router.navigate(['add'])
}
}
