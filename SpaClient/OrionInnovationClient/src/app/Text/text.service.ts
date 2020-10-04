import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

import { Text as TextModel } from './text.model';
import { WordsCount } from './wordsCount.model';

@Injectable({
    providedIn: 'root'
})
export class TextService {

    constructor(private http: HttpClient) {}

    fetchFromDb(id: number): Observable<TextModel> {
        return this.http.get<TextModel>(`${environment.apiUrl}/text/${id}/from_db`);
    }

    fetchFromFile(id: number): Observable<TextModel> {
        return this.http.get<TextModel>(`${environment.apiUrl}/text/${id}/from_file_system`);
    }

    countWords(text: string): Observable<WordsCount> {
        return this.http.post<WordsCount>(`${environment.apiUrl}/text/count_words`, { content: text});
    }
}

