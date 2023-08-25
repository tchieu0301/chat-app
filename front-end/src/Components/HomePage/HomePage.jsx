import { useState } from "react";

export default function Homepage() {
  const [messages, setMessages] = useState([]);
  const [newMessage, setNewMessage] = useState("");

  const handleInputChange = (event) => {
    setNewMessage(event.target.value);
  };

  const handleSendMessage = (event) => {
    event.preventDefault();
    if (newMessage.trim() !== "") {
      setMessages([...messages, newMessage]);
      setNewMessage("");
    }
  };
  const Message = ({message}) => {
    return (
      <div>
        {message.map((message, index) => (
          <div key={index} className="">
            {message}
          </div>
        ))}
      </div>
    );
  };
  return (
    <div className="grid grid-cols-2 h-screen">
      <div className=""></div>
      <div className="border-solid border-2 border-black h-full relative">
        <div className="mt-5 mb-5">Username</div>
        <Message message={messages} />
        <form className="">
          <input
            className="border-solid border-2 w-4/5 absolute bottom-0 rounded-full pl-5 py-2"
            type="text"
            placeholder="Type your message"
            value={newMessage}
            onChange={handleInputChange}
          />
          <button
            onClick={handleSendMessage}
            className="absolute bottom-0 right-5 border-solid border-2 border-black rounded-full pl-2 py-2"
          >
            Send message
          </button>
        </form>
      </div>
    </div>
  );
}
