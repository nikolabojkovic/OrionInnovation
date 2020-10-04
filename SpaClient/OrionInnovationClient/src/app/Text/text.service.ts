import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { Text as TextModel } from './text.model';

@Injectable({
    providedIn: 'root'
})
export class TextService {

    constructor(private http: HttpClient) {}

    fetchFromDb(id: number): Observable<TextModel> {
        return this.http.get<TextModel>(`http://localhost:5000/text/${id}/from_db`);
    }

    fetchFromFile(id: number): Observable<TextModel> {
        return this.http.get<TextModel>(`http://localhost:5000/text/${id}/from_file_system`);
    }

    countWords(text: string): Observable<any> {
        return this.http.post<any>(`http://localhost:5000/text/count_words`, { content: text});
    }
}

