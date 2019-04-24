import { Component, OnInit } from '@angular/core';
import { IProduct } from '../model/product';
import { ProductoService } from '../model/producto.service';
import { debug } from 'util';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  products: IProduct[];

  constructor(private productService: ProductoService) { }

  ngOnInit() {
    debugger;
    this.productService.getProducts()
      .subscribe(productsWS => this.products = productsWS,
      error => console.log(error));
  }

}
