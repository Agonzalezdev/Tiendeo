import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})
export class AppComponent implements OnInit{
  mapIconDefaultWidth: number = 60;
  mapIconDefaultHeigth: number = 60;
  lat: number = 41.38559;
  lng: number = 2.168745;

  constructor(
  ) { }

  ngOnInit() {
  }

  markers = [
    { lat: 41.40588, lng: 2.191681, iconUrl: 'https://static0.tiendeo.com/upload_negocio/negocio_43/marker.png' }
  ];
}

