import { Component, Inject, OnInit, ViewChild } from '@angular/core';
import {
  MatBottomSheet,
  MatBottomSheetRef,
  MAT_BOTTOM_SHEET_DATA,
} from '@angular/material/bottom-sheet';
import { PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Company } from 'src/app/core/models/dbModels';
import { BaseSearchCriteria } from 'src/app/core/models/searchCriteria';
import { NotificationBarService } from 'src/app/core/services/notification-bar.service';
import { CompanyService } from './../../services/company.service';

@Component({
  selector: 'bottom-sheet-overview',
  templateUrl: 'bottom-sheet-overview.html',
})
export class BottomSheetOverviewExampleSheet {
  constructor(
    private _bottomSheetRef: MatBottomSheetRef<BottomSheetOverviewExampleSheet>,
    @Inject(MAT_BOTTOM_SHEET_DATA) public data: { company: Company }
  ) {}

  openLink(event: MouseEvent): void {
    this._bottomSheetRef.dismiss();
    event.preventDefault();
  }
}

@Component({
  selector: 'app-companies-list',
  templateUrl: './companies-list.component.html',
  styleUrls: ['./companies-list.component.scss'],
})
export class CompaniesListComponent implements OnInit {
  search = new BaseSearchCriteria();
  companies = new Array<Company>();
  dataSource = new MatTableDataSource();
  displayedColumns: string[] = ['name', 'actions'];
  constructor(
    private companyService: CompanyService,
    private notificationService: NotificationBarService,
    private _bottomSheet: MatBottomSheet
  ) {}

  ngOnInit(): void {
    this.loadCompanies();
  }
  loadCompanies(): void {
    this.companyService.getAll(this.search).subscribe(
      (data) => {
        this.search.loadResultList(data);
        this.dataSource.data = data.model;
        this.companies = data.model;
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
  openBottomSheet(company: Company): void {
    this._bottomSheet.open(BottomSheetOverviewExampleSheet, {
      data: { company },
    });
  }
}
