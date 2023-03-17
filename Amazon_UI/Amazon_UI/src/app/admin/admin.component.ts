import { Component ,OnInit} from '@angular/core';
import { User } from '../Models/user';
import { UserserviceService } from '../Services/userservice.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {
  us:Array<User>=[]
constructor(public user:UserserviceService){
  /*this.user.getdata().subscribe(
    (success)=>{
      this.us=success    }
  )*/
}
  ngOnInit(): void {
  
}
}
