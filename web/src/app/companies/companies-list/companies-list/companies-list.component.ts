import { Component, OnInit, ViewChild } from '@angular/core';
import { PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { Company } from 'src/app/core/models/dbModels';
import { BaseSearchCriteria } from 'src/app/core/models/searchCriteria';
import { CompanyService } from '../services/company.service';

@Component({
  selector: 'app-companies-list',
  templateUrl: './companies-list.component.html',
  styleUrls: ['./companies-list.component.scss'],
})
export class CompaniesListComponent implements OnInit {
  search = new BaseSearchCriteria();
  dataSource = new MatTableDataSource();
  displayedColumns: string[] = ['name', 'actions'];
  constructor(private companyService: CompanyService) {}

  ngOnInit(): void {
    this.loadCompanies();
  }
  loadCompanies(): void {
    this.companyService.getAll(this.search).subscribe(
      (data) => {
        this.search.loadResultList(data);
        this.dataSource.data = data.model;
      },
      (error) => {}
    );
  }
  load(event:PageEvent){
    this.search.page = event.pageIndex+1;
    this.search.perPage = event.pageSize;
    this.loadCompanies();
  }
}
