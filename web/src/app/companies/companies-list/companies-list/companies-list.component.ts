import { Component, OnInit, ViewChild } from '@angular/core';
import { PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { BaseSearchCriteria } from 'src/app/core/models/searchCriteria';
import { NotificationBarService } from 'src/app/core/services/notification-bar.service';
import { CompanyService } from './../../services/company.service';

@Component({
  selector: 'app-companies-list',
  templateUrl: './companies-list.component.html',
  styleUrls: ['./companies-list.component.scss'],
})
export class CompaniesListComponent implements OnInit {
  search = new BaseSearchCriteria();
  dataSource = new MatTableDataSource();
  displayedColumns: string[] = ['name', 'actions'];
  constructor(private companyService: CompanyService, private notificationService: NotificationBarService) { }

  ngOnInit(): void {
    this.loadCompanies();
  }
  loadCompanies(): void {
    this.companyService.getAll(this.search).subscribe(
      (data) => {
        this.search.loadResultList(data);
        this.dataSource.data = data.model;
      },
      (error) => {
        this.notificationService.openSnackBar(error.message);
      }
    );
  }
  load(event: PageEvent) {
    this.search.page = event.pageIndex + 1;
    this.search.perPage = event.pageSize;
    this.loadCompanies();
  }
}
