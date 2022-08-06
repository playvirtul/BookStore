import React, { useState, useEffect } from "react";

export default function App() {
    const [books, setBooks] = useState([]);

    useEffect(() => {
        const url = 'https://localhost:7200/api/books';
        fetch(url, {
            method: 'GET'
        })
            .then(res => res.json())
            .then(data => {
                console.log(data);
                setBooks(data);
            })
            .catch((error) => {
                console.log(error);
                alert(error);
            });
    }, []);

    function deleteBook(bookId) {
        const url = `https://localhost:7200/api/Books?id=${bookId}`;
        fetch(url, {
            method: 'DELETE'
        })
            .then(res => res.json())
            .then(res => {
                console.log(res);
                onBookDeleted(bookId);
            })
            .catch((error) => {
                console.log(error);
                alert(error);
            });
    }

    return (
        <div className="container">
            <div className="row min-vh-100">
                <div className="col d-flex flex-column justify-content-center align-items-center">
                    {renderPostsTable()}
                </div>
            </div>
        </div>
    );

    function renderPostsTable() {
        return (
            <table className="table table-bordered text-center">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Название</th>
                        <th scope="col">Автор</th>
                        <th scope="col">Год публикации</th>
                        <th scope="col">Купить</th>
                    </tr>
                </thead>
                <tbody>
                    {books.map((book) => (
                        <tr key={book.id}>
                            <th scope="row">{book.id}</th>
                            <td>{book.title}</td>
                            <td>{book.author}</td>
                            <td>{new Date(book.publishYear).getFullYear()}</td>
                            <td>
                                <button onClick={() => deleteBook(book.id)} type="button" className="btn btn-danger">Купить</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        )
    }

    function onBookDeleted(bookId) {
        let booksCopy = [...books];

        const index = booksCopy.findIndex((booksCopy, currentIdex) => {
            if (booksCopy.id === bookId) {
                return true;
            }
        });

        if (index !== -1) {
            booksCopy.splice(index, 1);
        }

        setBooks(booksCopy);
    }
}