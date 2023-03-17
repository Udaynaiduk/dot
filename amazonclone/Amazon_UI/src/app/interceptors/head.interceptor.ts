import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserserviceService } from '../Services/userservice.service';

@Injectable()
export class HeadInterceptor implements HttpInterceptor {

  constructor(private user:UserserviceService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const token =localStorage.getItem('token');// this.us.getToken();//retrieving the token from local storage
   if (token) { 
     // If we have a token, we set it to the header //http://localhost:5012/api/MusicService,{headers:{Authorization:Bear f98473947'}}
     request = request.clone({ //add token to request
        setHeaders: {Authorization: `Bearer ${token}`}
     });

   }
 
    return next.handle(request);
  }
}
