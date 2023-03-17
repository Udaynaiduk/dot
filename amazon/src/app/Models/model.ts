export interface SuggestedProduct {
    banerimage: string;
    category:Product
  }
  
  export interface NavigationItem {
    category: string;
    subcategories: string[];
  }
  
  export interface User {
   
    email: string;
    password:string;
  }
  
  // #region Product
  
 
  

  export interface Product {
    id: number;
    Title: string;
    category:string
    Description: string;
    Price: number;
    qty: number;
    ImageUrl: string;
  }
  
  
  
  // #endregion
  
  // #region Cart
  
  export interface CartItem {
  
    Title: Product;
    Email:User;
    Price:Product
    qty:number
    value:number


  }
  export interface Cart {
    
    cartItems: CartItem[];
    ordered: boolean;
    orderedOn: string;
  }
  
  
  
  // #endregion
  
  // #region Payment and Orders
  
  export interface PaymentMethod {
    id: number;
    type: string;
    provider: string;
    available: boolean;
    reason: string;
  }
  
  export interface Payment {
    id: number;
    user: User;
    paymentMethod: PaymentMethod;
    totalAmount: number;
    shipingCharges: number;
    amountReduced: number;
    amountPaid: number;
    createdAt: string;
  }
  
  export interface Order {
    id: number;
    user: User;
    cart: CartItem;
    payment: Payment;
    createdAt: string;
  }
  
  // #endregion