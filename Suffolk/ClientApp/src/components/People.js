import { useEffect, useState } from "react";
import { fetchPeople } from "../actions/peopleAction";

const People = () => {

    const [people, SetPeople] = useState([]);

    useEffect(() => {
        // declare the data fetching function
        const fetchData = async () => {
            const data = await fetchPeople();
            //const data = await response.json();
            console.log(data);
            SetPeople([...data]);
        }
        fetchData()

            .catch(console.error);
    }, [])

    return (
        <table className="table table-striped" aria-labelledby="tableLabel">
            <thead>
                <tr>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Date of Birth</td>
                </tr>
            </thead>
            <tbody>

                {people && people.map(p =>
                    <tr key={p.id}>
                        <td>{p.firstName}</td>
                        <td>{p.lastName}</td>
                        <td>{p.dateOfBirth}</td>
                       
                    </tr>
                )}
            </tbody>
        </table>
    );
}

export default People;