import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/core/models/dbModels';
import { BaseSearchCriteria } from 'src/app/core/models/searchCriteria';
import { NotificationBarService } from 'src/app/core/services/notification-bar.service';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent implements OnInit {
  search = new BaseSearchCriteria();
  products: Product[] = [];
  constructor(private prodService: ProductService, private notificationService: NotificationBarService) { }

  ngOnInit(): void {
    this.getAllProducts();
  }
  getAllProducts(): void {
    this.prodService.getAll(this.search).subscribe(data => {
      if (data.isSuccess) {
        this.search.loadResultList(data);
        this.products = data.model;
        console.log("PRODUCTS", this.products);
      }
    }, error => {
      this.notificationService.openSnackBar(error.message)
    })
  }

}
