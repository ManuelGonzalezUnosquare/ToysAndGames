import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Product } from 'src/app/core/models/dbModels';
import { BaseSearchCriteria } from 'src/app/core/models/searchCriteria';
import {ProductService} from 'src/app/core/services';
import { NotificationBarService } from 'src/app/core/services/notification-bar.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss'],
})
export class ProductListComponent implements OnInit {
  search = new BaseSearchCriteria();
  products: Product[] = [];
  dataSource = new MatTableDataSource();
  displayedColumns: string[] = ['name', 'price', 'actions'];
  constructor(
    private prodService: ProductService,
    private notificationService: NotificationBarService,
    public dialog: MatDialog
  ) {}

  ngOnInit(): void {
    this.getAllProducts();
  }
  getAllProducts(): void {
    this.prodService.getAll(this.search).subscribe(
      (data) => {
        if (data.isSuccess) {
          this.search.loadResultList(data);
          this.dataSource.data = data.model;
          this.products = data.model;
        }
      },
      (error) => {
        this.notificationService.openSnackBar(error.message);
      }
    );
  }
  load(event: PageEvent) {
    this.search.page = event.pageIndex + 1;
    this.search.perPage = event.pageSize;
    this.getAllProducts();
  }
  searchProducts(): void {
    if (this.search.hint && this.search.hint.length % 3 === 0) {
      this.getAllProducts();
    } else if (!this.search.hint) {
      this.getAllProducts();
    }
  }
  clearSearch(): void {
    delete this.search.hint;
    this.searchProducts();
  }
}
