import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { FormsModule } from '@angular/forms';
import{HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { SellerLoginComponent } from './seller-login/seller-login.component';
import { SellerRegisterComponent } from './seller-register/seller-register.component';

import { HomeComponent } from './home/home.component';
import { ProductIComponent } from './product-i/product-i.component';
import { ProductFormsComponent } from './product-forms/product-forms.component';
import { CartComponent } from './cart/cart.component';
import { CartService } from './Services/cart.service';
import { HeadInterceptor } from './interceptors/head.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    LoginComponent,
    RegisterComponent,
    SellerLoginComponent,
    SellerRegisterComponent,
  
    

       HomeComponent,
        ProductIComponent,
        ProductFormsComponent,
        CartComponent,
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule

  ],
  providers: [CartService,
    {
      provide:HTTP_INTERCEPTORS,
      useClass:HeadInterceptor,
      multi:true
  }],

  bootstrap: [AppComponent]
})
export class AppModule { }
