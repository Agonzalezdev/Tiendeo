import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Store } from './../_models/store';
import { StoreSearch } from './../_models/storeSearch';
import { environment } from './../environments/environment';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class StoreService {
  private serviceUrl: string = environment.apiUrl + '/api/stores';

  constructor(private http: HttpClient) {}

  searchStores(searchParams: StoreSearch): Observable<Store[]> {
    let params = new HttpParams();
    params = params.append('fromLatitude', searchParams.fromLatitude != undefined ? searchParams.fromLatitude.toString() : "");
    params = params.append('toLatitude', searchParams.toLatitude != undefined ? searchParams.toLatitude.toString() : "");
    params = params.append('fromLongitude', searchParams.fromLongitude != undefined ? searchParams.fromLongitude.toString() : "");
    params = params.append('toLongitude', searchParams.toLongitude != undefined ? searchParams.toLongitude.toString() : "");
    params = params.append('maxResults', searchParams.maxResults != undefined ? searchParams.maxResults.toString() : "");
    return this.http.get<Store[]>(this.serviceUrl, { params: params });
  }


}
