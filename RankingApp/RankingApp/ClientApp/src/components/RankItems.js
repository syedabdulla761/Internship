import React, { useState, useEffect } from 'react';
import MovieImageArr from './MovieImages';
import RankingGrid from './RankingGrid';

const RankItems = () => {

    const [items, setItems] = useState([]);
    const dataType = 1;

    function drag(ev) {
        ev.dataTransfer.setdata("text", ev.target.id);
    }

    function allowDrop(ev) {
        ev.preventDefault();
    }

    useEffect(() => {
        fetch(`item/${dataType}`)
            .then((results) => {  
                return results.json();
            })
            .then(data => {
                setItems(data);
            })
    },[])

    return (

        <main>
            <RankingGrid items={items} imgArr={MovieImageArr}/>
        <div className="items-not-ranked">
        { 
                    (items != null) ? items.map((item) =>
                    <div className="unranked-cell">
                            <img alt={item.title} id={`item-${item.id}`} src={MovieImageArr.find(o=>o.id===item.imageId)?.image }/>
                    </div>
                    ): <div>Loading....</div>
         }
        </div>
        </main>
    )
}
export default RankItems;