import Navbar from '@/components/navbar';
import User from '@/components/user';
import Head from 'next/head';
import Axios from 'axios';
import { useEffect, useState } from 'react';
import UserList from '@/components/userlist';
import Search from '@/components/search';


export default function Home() {
  const [users, setUsers] = useState([]);
  const [loading, setLoading] = useState(false);

  const searchUsers = (keyword) => {
    Axios
      .get(`https://api.github.com/search/users?q=` + keyword)
      .then(response => setUsers(response.data.items))
      .catch(error => console.log(error));
  }


  useEffect(() => {
    setLoading(false);
  }, [users]);

  const clearResults=()=>{
    setUsers([]);
  }

  return (
    <>
      <Head>
        <title>Github Finder</title>
        <meta name="description" content="Brigth 2023-1 grubu tarafından hazırlanmıştır" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="icon" href="/favicon.ico" />
      </Head>
      <main className="container mt-3 d-flex flex-column justify-content-center align-items-center">
        <Navbar />
        <Search searchUsers={searchUsers} setLoading={setLoading} clearResults={clearResults} showClearButton={users.length == 0 ? false : true} />
        <UserList users={users} loading={loading} />
      </main>

    </>
  )
}
