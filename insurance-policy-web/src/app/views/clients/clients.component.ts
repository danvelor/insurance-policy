import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { DataProvider } from 'src/app/providers/data.provider';
import { ClientsService } from './clients.service';
import { clientsmodel } from 'src/app/models/clients.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html',
  styleUrls: ['./clients.component.scss']
})
export class ClientsComponent implements OnInit {
  displayedColumns: string[] = ['name', 'phone', 'numInsurance', 'edit'];
  dataSource: MatTableDataSource<clientsmodel>;

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  constructor(public data: DataProvider
    , public service: ClientsService
    , public router: Router) {
 

    service.getClients().subscribe((response: any) => {
      console.log(response);

      this.dataSource = new MatTableDataSource(response);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    }, (e: any) => {
    })
  }

  edit(row: any) {
    console.log(row);
    this.data.idclient = row.clientId;
    this.router.navigate(['Clientdetail']);
  }

  create() {
    this.router.navigate(['insurancepolicy']);
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

