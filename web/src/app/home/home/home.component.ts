import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/core/models/dbModels';
import { BaseSearchCriteria } from 'src/app/core/models/searchCriteria';
import { HomeService } from '../services/home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  products = new Array<Product>();
  searchProducts = new BaseSearchCriteria();
  constructor(private homeService: HomeService) {}

  ngOnInit(): void {
  this.getAllProducts();
  }
  getAllProducts(): void {
    this.homeService.getAll(this.searchProducts).subscribe(
      (data) => {
        this.products = data.model;
	console.log("Home Products",this.products);
      },
      (error) => {}
    );
  }
}
