import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CartComponent } from './cart/cart.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { ProductFormsComponent } from './product-forms/product-forms.component';
import { ProductIComponent } from './product-i/product-i.component';

import { RegisterComponent } from './register/register.component';
import { SellerLoginComponent } from './seller-login/seller-login.component';
import { SellerRegisterComponent } from './seller-register/seller-register.component';

const routes: Routes = [
  {path:"Login",component:LoginComponent},
  {path:"Register",component:RegisterComponent},
  {path:"sellerR",component:SellerRegisterComponent},
  {path:"sellerL",component:SellerLoginComponent},
  {path:'Home',component:HomeComponent},
  {path:"product",component:ProductIComponent},
  {path:"items",component:ProductFormsComponent},
  {path:"cart",component:CartComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
