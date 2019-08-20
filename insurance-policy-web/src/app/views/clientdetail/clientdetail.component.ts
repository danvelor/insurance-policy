import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { DataProvider } from 'src/app/providers/data.provider';
import { ClientdetailService } from './clientdetail.service';
import { clientdetailmodel } from 'src/app/models/clientdetail.model';
import { Router } from '@angular/router';
import { Response } from 'selenium-webdriver/http';

@Component({
  selector: 'app-clientdetail',
  templateUrl: './clientdetail.component.html',
  styleUrls: ['./clientdetail.component.scss']
})
export class ClientdetailComponent implements OnInit {
  displayedColumns: string[] = ['name', 'description', 'type', 'percent', 'startDate', 'duration', 'cost', 'risk'];
  dataSource: MatTableDataSource<clientdetailmodel>;

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  constructor(
    public data: DataProvider
    , public service: ClientdetailService
    , public router: Router) {

  

    service.getClientDetail().subscribe((response:any) => {
      console.log(response);
      this.dataSource = new MatTableDataSource(response);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    }, (e: any) => {
    })
  }

  ngOnInit() {
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

}
