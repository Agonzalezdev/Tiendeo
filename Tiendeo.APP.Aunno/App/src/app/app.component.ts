import { Component, OnInit, ViewChild } from '@angular/core';
import { StoreService } from './../_services/store.service';
import { StoreSearch } from '../_models/storeSearch';
import { Store } from '../_models/store';
import { AgmMap } from '@agm/core';
import { CityService } from '../_services/city.service';
import { City } from '../_models/city';
import { MatDialog, MatDialogRef, MatDialogConfig } from '@angular/material';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less']
})
export class AppComponent implements OnInit {
  @ViewChild(AgmMap, { static: false }) map: any;
  defaultZoom: number = 15;
  mapIconDefaultWidth: number = 60;
  mapIconDefaultHeigth: number = 60;

  mapLatitude: number;
  mapLongitude: number;
  
  markers: Store[];
  allCities: City[];
  storeSearch: StoreSearch = new StoreSearch();
  selectedCity: number;


  constructor(
    private _storeService: StoreService,
    private _cityService: CityService
  ) { }

  ngOnInit() {
    this.loadCities();
    this.storeSearch.maxResults = 10;
  }


  loadCities() {
    this._cityService.getAllCities().subscribe(res => {
      this.allCities = res;
      if (this.allCities.length > 0) {
        this.mapLatitude = this.allCities[0].latitude;
        this.mapLongitude = this.allCities[0].longitude;
        this.selectedCity = this.allCities[0].id;
      }
    });
  }

  cityChanged() {
    let selectedCity = this.allCities.filter(e => e.id == this.selectedCity)[0];
    this.mapLatitude = selectedCity.latitude;
    this.mapLongitude = selectedCity.longitude;
  }

  loadStoreData() {

    this.map._mapsWrapper.getBounds()
      .then((latLngBounds) => {
        this.storeSearch.fromLatitude = latLngBounds.getNorthEast().lat();
        this.storeSearch.fromLongitude = latLngBounds.getNorthEast().lng();
        this.storeSearch.toLatitude = latLngBounds.getSouthWest().lat();
        this.storeSearch.toLongitude = latLngBounds.getSouthWest().lng();
        if (this.map != undefined) {
          this._storeService.searchStores(this.storeSearch).subscribe(res => {
            this.markers = res;
          });
        }
      }); 
  }

}

