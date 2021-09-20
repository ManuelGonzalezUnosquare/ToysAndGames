import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product } from 'src/app/core/models/dbModels';
import { NotificationBarService } from 'src/app/core/services/notification-bar.service';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss']
})
export class ProductDetailsComponent implements OnInit {
  product: Product;
  title = 'New Product';
  constructor(private productService: ProductService, private notificationService: NotificationBarService, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    let guid = this.activatedRoute.snapshot.params.guid;
    if (guid) {
      this.title = 'Product Details';
      this.getProductById(guid);
    }

  }
  getProductById(guid: string): void {
    this.productService.getByGuid(guid).subscribe(data => {
      if (data.isSuccess) {
        this.product = data.model;
        console.log("prod", this.product);
      }
      else {
        this.notificationService.openSnackBar(data.error);
      }
    }, error => {
      this.notificationService.openSnackBar(error.message);
    })
  }

}