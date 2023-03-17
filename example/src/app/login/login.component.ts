import { Component, OnInit } from '@angular/core';
import { Logins } from '../models/logins';
import { JewelleryService } from '../services/jewellery.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  
}
