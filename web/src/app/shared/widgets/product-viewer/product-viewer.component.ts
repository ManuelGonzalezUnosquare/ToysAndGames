import { Component, OnInit } from '@angular/core';
import {Product} from 'src/app/core/models/dbModels';
import {BaseSearchCriteria} from 'src/app/core/models/searchCriteria';
import {ProductService} from 'src/app/core/services';

@Component({
  selector: 'app-product-viewer',
  templateUrl: './product-viewer.component.html',
  styleUrls: ['./product-viewer.component.scss']
})
export class ProductViewerComponent implements OnInit {
  search= new BaseSearchCriteria();
  products:Product[]=[];
  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.getProducts();
  }
  getProducts():void{
    this.productService.getAll(this.search).subscribe(data=>{
      this.products = data.model;
    })
  }
}
