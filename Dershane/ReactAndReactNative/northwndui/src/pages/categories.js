/*general*/
import React, {useEffect, useState} from "react";
import Axios from "axios";

/*components*/
import CategoryListItem from "../components/category/listitemcategory";

/*style*/


/********************************************/

const Categories = () => {
    const [categories, setCategories] = useState([]);

    useEffect(()=> {
        Axios.get('/api/category', {
        auth: {
            username: "alp",
            password: "1234!"
        }
        }).then(res => {
            console.log(res.data);
            setCategories(res.data);
        })
        .catch(err => console.log(err));
    }, []);

    return (
        <div>
            <h1>Categories Page</h1>

            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Description</th>
                    </tr>
                </thead>
    
                <tbody>
                    {categories.map((data, i)=> (
                        <CategoryListItem id={data.id} name={data.isim} description={data.aciklama} />
                    ))}
                </tbody>
            </table>
        </div>
    );
}

export default Categories;