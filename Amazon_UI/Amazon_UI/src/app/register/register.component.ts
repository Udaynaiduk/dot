import { Component ,OnInit} from '@angular/core';
import { User } from '../Models/user';
import { UserserviceService } from '../Services/userservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  
us:User=new User();
constructor(public user:UserserviceService){

}

ngOnInit(): void {
  
}
  
registerhandel(){
  this.user.register(this.us);
  this.us=new User();
}

}
