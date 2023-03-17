import { Component ,OnInit} from '@angular/core';
import { User } from '../Models/user';
import { UserserviceService } from '../Services/userservice.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
lo:User=new User()
constructor(public user:UserserviceService){}

  ngOnInit(): void {
    
  }
  LoginHandel(){
    this.user.login(this.lo)
    this.lo=new User();
  }
  

}
